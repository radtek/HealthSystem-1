// 基于准备好的dom，初始化echarts实例
var myChart = echarts.init(document.getElementById('heartContainer'))
var arr = [95, 93, 91, 95, 93, 91, 94, 98, 99, 93, 94, 98, 99, 93]
var tarr = [0]
for (var i = 1; i < 20; i++) {
    tarr.push('0')
}
    // 指定图表的配置项和数据
var option = {
    title: {
        text: '心跳数据采集图'
    },
    tooltip: {
        trigger: 'axis'
    },
    legend: {
        data: ['心跳数据']
    },
    toolbox: {
        feature: {
            saveAsImage: {}
        }
    },
    grid: {
        left: '3%',
        right: '4%',
        bottom: '3%',
        containLabel: true
    },
    xAxis: [{
        type: 'category',
        boundaryGap: false,
        name:'日期',
        data: []
    }],
    yAxis: [{
        type: 'value',
        max: 180,
        min: 0,
        name:'心跳',
        splitNumber: 10
    }],
    series: [

        {
            name: '心跳数据',
            type: 'line',
            smooth: true,
            stack: '总量',
            label: {
                normal: {
                    show: true,
                    position: 'top'
                }
            },
            areaStyle: {
                normal: {}
            },
            data: [0],//必须要这个，至少一个值，否则ajax拿到数据后也不能绘图
        }
    ]
}



// 使用刚指定的配置项和数据显示图表。
myChart.setOption(option)

var template = {
    // 'foo': randomnum,
    'data': function() {
        for (var i = 0; i < 1; i++) {
            var randomnum = parseInt(Math.random() * (100 - 10 + 1) + 10)
            arr.push(randomnum)
            arr.shift()
        }
        return arr
    },
    'date':function(){
        var time = Mock.mock('@now()')
        tarr.push(time)
        tarr.shift()
        return tarr
    }
}
Mock.mock(/\.json/, template)
var urlname = 'hello.json'

function ajax() {
    $.ajax({
        // url: urlname,
        url: 'hello.json',
        dataType: 'json'
    }).done(function(data, status, jqXHR) {
        // 填入数据
        console.log(data)
        myChart.setOption({
            // xAxis: [{
            //     data: data.date
            // }],
            series: [{
                // data: data.data
                data:[95, 93, 91, 95, 93, 91, 94, 98, 99, 93, 94, 98, 99]
            }]
        })
    })
}


ajax()
// setInterval(ajax, 500)