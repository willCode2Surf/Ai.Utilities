graphs.barchart = function(container) {
    $(container).children('.barchart').each(function (index, data) {
        var domElement = $(data);
        var url = "";
        var title = "";

        if (utilities.data.hasDataAttribute(domElement, 'title')) {
            title += utilities.data.getDataAttribute(domElement, 'title');
        }

        if (utilities.data.hasDataAttribute(domElement, 'url')) {
            url += utilities.data.getDataAttribute(domElement, 'url');
        }

        if (url != "") {
            $.getJSON(url, function (chartData) {
                $(domElement).highcharts({
                    chart: {
                        type: 'column',
                        zoomType: 'x'
                    },
                    title: {
                        text: title
                    },
                    xAxis: {
                        categories: chartData.Categories
                    },
                    plotOptions: {
                        column: {
                            pointPadding: 0,
                            borderWidth: 0
                        }
                    },
                    yAxis: { title: null },
                    series: chartData.Series
                });
            });
        }
    });
};
