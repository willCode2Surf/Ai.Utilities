graphs.bind = function (container) {
    graphs.barchart(container);
    graphs.linechart(container);
};


$(function () {
    graphs.bind($('body'));
})