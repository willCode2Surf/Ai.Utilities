utilities.string = function () {
    var that = {};

    that.format = function (str, values) {
        $(values).each(function (index, data) {
            var lookup = "{" + index + "}";
            str = str.replace(lookup, data);
        });

        return str;
    };
    return that;
}();