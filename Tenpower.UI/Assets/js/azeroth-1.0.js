/// <reference path="jquery-1.11.2.js" />
/// <reference path="../echarts-2.2.6/echarts.js" />

(function () {
    if (!window["azeroth"])
        window["azeroth"] = {};
    window.azeroth["getEchartOPT"] = function (title, subtitle) {
        return {
            title: {
                text: title,
                subtext: subtitle
            },
            tooltip: {
                trigger: 'axis'
            },
            legend: {
                data: []
            },
            toolbox: {
                show: false,
                feature: {
                    mark: { show: false },
                    dataView: { show: false, readOnly: false },
                    magicType: { show: false, type: ['line', 'bar', 'stack', 'tiled'] },
                    restore: { show: false },
                    saveAsImage: { show: false },
                    btnscale: {
                        show: true,
                        title: 'scale',
                        icon: '/Assets/img/Zoom.bmp',
                        onclick: function (chartopt) {
                            var value = (chartopt.yAxis[0].boundaryGap[0] + 1) % 5;
                            chartopt.yAxis[0].boundaryGap = [value, value];
                            this.myChart.refresh();
                        }
                    },
                    btnedit: {
                        show: false,
                        title: '备注',
                        icon: '/Assets/img/setup.bmp',
                        onclick: function () {
                            alert("备注");
                        }
                    }
                }
            },
            xAxis: {
                type: 'category',
                boundaryGap: false,
                data: [],
                splitLine: {
                    show: false, onGap: null, lineStyle: {
                        color: ['#ccc'],
                        width: 1,
                        type: 'solid'
                    }
                }
            },
            yAxis: {
                scale: true,
                type: 'value',
                boundaryGap: [2, 2],
            },
            series: [],
            grid: {
                x: 30,
                y: 20,
                x2: 10,
                y2: 30
            }
        };
    };

    var echartoptdict = [];
    var echarting = false;
    var echartInited = false;
    window.azeroth["createEchartImg"] = function (selector, opt, callback, paths) {
        function createEchartImgInternal(ec) {
            var obj;
            while (obj = echartoptdict.pop()) {
                var chart = ec.init($(obj.selector)[0]);
                chart.setOption(obj.opt);
                if (obj.callback)
                    callback(obj.selector, chart);
            }
            echarting = false;
            echartInited = true;
        };
        echartoptdict.push({ "selector": selector, "opt": opt, "callback": callback, "paths": paths });
        if (echarting)
            return;
        echarting = true;
        if (echartInited && !paths)
            createEchartImgInternal(window.require("echarts"));
        else
            window.require(paths, createEchartImgInternal);
    }
})($);