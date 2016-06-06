$(function(){
	var columnsData = [{
	field: 'state',
	checkbox: true
}, {
	field: 'id',
	title: 'Item ID',
	editable: true,
	align: 'center'
}, {
	field: 'firstname',
	title: 'Item FirsName',
	editable: true,
	align: 'center'
}, {
	field: 'lastname',
	title: 'Item LastName',
	align: 'center'
}, {
	field: 'email',
	title: 'Item Email',
	align: 'center'
}]

$('#table').bootstrapTable({
	url: '{:U("SensorData/usersTable")}',
	pagination: true,
	pageSize: 4,
	sidePagination: 'server', //服务端分页
	pageList: [5, 10, 'ALL'], //如果数据只有5条,数值5之后的数字不会显示
	//pageList: [5, 10, 20, 50, 100, 200],
	search: true,
	showColumns: true, //显示选择哪列是否显示的控件
	showRefresh: true,
	showToggle: true, //转换表格数据表现形式
	showPaginationSwitch: true, //显示控制是否显示分页按钮组的控件来的
	clickToSelect: true, //点击一行，选择框自动打钩
	showExport: true,
	exportTypes: ['json', 'xml', 'csv', 'txt', 'sql', 'doc', 'excel'],
	onEditableSave: function(field, row, oldValue, $el) {
		$.ajax({
			type: "post",
			url: '{:U("Index/edit")}',
			// url: "/Editable/Edit",
			data: {
				strJson: JSON.stringify(row)
			},
			success: function(data, status) {
				if (status == "success") {
					console.log(data)
					alert("编辑成功");
				}
			},
			error: function() {
				alert("Error");
			},
			complete: function() {
				alert("complete");
			}
		});
	},
	// toolbar: '#toolbar',
	// exportDataType: 'basic',
	// queryParamsType: "limit",//查询参数组织方式
	// queryParams: function getParams(params) {
	//  return params;
	// },
	// height: function tableHeight() {
	//  return $(window).height() - 50;
	// },
	columns: columnsData,
});

$('#table2').bootstrapTable({
	url: HHH,
	pagination: true,
	pageSize: 4,
	sidePagination: 'server', //服务端分页
	pageList: [5, 10, 'ALL'], //如果数据只有5条,数值5之后的数字不会显示
	//pageList: [5, 10, 20, 50, 100, 200],
	search: true,
	showColumns: true, //显示选择哪列是否显示的控件
	showRefresh: true,
	showToggle: true, //转换表格数据表现形式
	showPaginationSwitch: true, //显示控制是否显示分页按钮组的控件来的
	clickToSelect: true, //点击一行，选择框自动打钩
	showExport: true,
	exportTypes: ['json', 'xml', 'csv', 'txt', 'sql', 'doc', 'excel'],
	onEditableSave: function(field, row, oldValue, $el) {
		$.ajax({
			type: "post",
			url: '{:U("Index/edit")}',
			// url: "/Editable/Edit",
			data: {
				strJson: JSON.stringify(row)
			},
			success: function(data, status) {
				if (status == "success") {
					console.log(data)
					alert("编辑成功");
				}
			},
			error: function() {
				alert("Error");
			},
			complete: function() {
				alert("complete");
			}
		});
	},
	// toolbar: '#toolbar',
	// exportDataType: 'basic',
	// queryParamsType: "limit",//查询参数组织方式
	// queryParams: function getParams(params) {
	//  return params;
	// },
	// height: function tableHeight() {
	//  return $(window).height() - 50;
	// },
	columns: columnsData,
});
})
