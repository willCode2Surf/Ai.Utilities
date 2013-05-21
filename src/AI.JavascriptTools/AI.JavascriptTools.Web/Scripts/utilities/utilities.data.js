utilities.data = function () {
    var self = this;
    var that = {};

    that.hasDataAttribute = function(domElement, attribute) {
        var has = $(domElement).data(attribute);
        return typeof has != 'undefined';
    };
    
    that.getDataAttribute = function(domElement, attribute) {
        if (that.hasDataAttribute(domElement, attribute)) {
            return $(domElement).data(attribute);
        }
        throw new Error("DOM Element does not contain data attribute : " + attribute);
    };

    return that;
}();