$(function() {
	// To control side bar
	$('.hide-sidebar').click(function() {
		$('#sidebar').hide('fast', function() {
			$('#content').removeClass('col-md-10')
			$('#content').addClass('col-md-12')
			$('.hide-sidebar').hide()
			$('.show-sidebar').show()
		})
	})

	$('.show-sidebar').click(function() {
		$('#content').removeClass('col-md-12')
		$('#content').addClass('col-md-10')
		$('.show-sidebar').hide()
		$('.hide-sidebar').show()
		$('#sidebar').show('fast')
	})

	//toastr 参数设置
	toastr.options = {
		"closeButton": false, //是否显示关闭按钮
		"debug": false, //是否使用debug模式
		"positionClass": "toast-top-right", //弹出窗的位置
		"showDuration": "300", //显示的动画时间
		"hideDuration": "1000", //消失的动画时间
		"timeOut": "3000", //展现时间
		"extendedTimeOut": "1000", //加长展示时间
		"showEasing": "swing", //显示时的动画缓冲方式
		"hideEasing": "linear", //消失时的动画缓冲方式
		"showMethod": "fadeIn", //显示时的动画方式
		"hideMethod": "fadeOut" //消失时的动画方式
	}


})