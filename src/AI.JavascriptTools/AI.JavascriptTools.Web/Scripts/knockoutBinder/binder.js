binder = function() {
    self.getData = function(url, callback) {
        $.getJSON(url, function(data) {
            return callback(data);
        });
    };

    self.convertToObservable = function (source, destination) {
        for (var prop in source) {
            if ($.isArray(source[prop])) {
                $(source[prop]).each(function(index, data) {
                    destination[prop] = ko.observableArray([]);
                    var result = {};
                    destination[prop].push(self.convertToObservable(data, result));
                });
            } else if ($.isPlainObject(source[prop])) {
                destination[prop] = {};
                destination[prop] = ko.observable(self.convertToObservable(source[prop], destination[prop]));
            }
            else {
                destination[prop] = ko.observable(source[prop]);
            }
        }
        
        return destination;
    };
    
    $(function () {
        $('.bindable').each(function(index, data) {
            var url = "";
            var domElement = $(data);
            if (utilities.data.hasDataAttribute(domElement, 'url'))
            {
                url += utilities.data.getDataAttribute(domElement, 'url');
            }
            
            if (url !== "") {
                self.getData(url, function (viewModel) {
                    if ($(domElement).hasClass('observable')) {
                        var observableViewModel = {};
                        self.convertToObservable(viewModel, observableViewModel);
                        ko.applyBindings(observableViewModel, $(domElement)[0]);
                    }
                    ko.applyBindings(viewModel, $(domElement)[0]);
                });
            }
        });
    });
}();