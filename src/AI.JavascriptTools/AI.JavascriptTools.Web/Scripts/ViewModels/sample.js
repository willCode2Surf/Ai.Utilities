var viewModels = {};
viewModels.sample = function () {
    var that = {};
    var self = this;
    
    that.FullName = ko.observable();

    that.init = function () {
        that.Name().FirstName.subscribe(self.buildFullName());
        that.Name().LastName.subscribe(self.buildFullName());
        self.buildFullName();
    };

    self.buildFullName = function() {
        that.FullName(that.Name().LastName() + ', ' + that.Name().FirstName());
    };
    
    return that;
};