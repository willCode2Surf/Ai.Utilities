graphs.linechart = function(container) {
    $(container).children('.linechart').each(function(index, data) {
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
            $.getJSON(url, function(chartData) {
                $(domElement).highcharts({
                    chart: {
                        type: 'line'
                    },
                    title: {
                        text: title
                    },
                    xAxis: {
                        categories: chartData.Categories
                    },
                    yAxis: { title: null },
                    series: chartData.Series
                });
            });
        }
    });
};