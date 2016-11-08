<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="WebApp.account.member.upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/assets/lib/jqueryui/demos.css" rel="stylesheet" />
    <script src="/assets/lib/jquery/jquery-1.11.0.js"></script>
    <script src="/assets/lib/jqueryui/jquery-ui.js"></script>
    <script src="/assets/lib/swfupload/swfupload.js"></script>
    <script src="/assets/lib/swfupload/handlers.js"></script>
    <script type="text/javascript">
        var swfu;
        var imgSrc;
		window.onload = function () {
			swfu = new SWFUpload({
				// Backend Settings
				upload_url: 'upload.aspx',
                post_params : {
                    'ASPSESSID' : '<%=Session.SessionID %>'
                },

				// File Upload Settings
				file_size_limit : '2 MB',
				file_types : '*.jpg',
				file_types_description : 'JPG Images',
				file_upload_limit : 1,    // Zero means unlimited

				// Event Handler Settings - these functions as defined in Handlers.js
				//  The handlers are not part of SWFUpload but are part of my website and control how
				//  my website reacts to the SWFUpload events.
				swfupload_preload_handler : preLoad,
				swfupload_load_failed_handler : loadFailed,
				file_queue_error_handler : fileQueueError,
				file_dialog_complete_handler : fileDialogComplete,
				upload_progress_handler : uploadProgress,
				upload_error_handler : uploadError,
			    //upload_success_handler : uploadSuccess,
				upload_success_handler: function (file, serverData) {
                   
				    console.log(serverData);
				    //var dom = document.getElementById('img_src');
				    //dom.src = serverData.substr(1);
				    var img = new Image();
				     imgSrc= serverData.substr(1);
				     img.src = imgSrc;
				    img.onload = function () {
				        $('#thumbnails').css('backgroundImage', 'url('+img.src+')')
                                        .css('height', img.height)
                                        .css('width', img.width);
                        $('#catch').css('display','block')
                        $("#catch").draggable({ containment: "parent" });
				    };
				},
				upload_complete_handler : uploadComplete,

				// Button settings
				button_image_url: '/assets/lib/swfupload/images/XPButtonNoText_160x22.png',
				button_placeholder_id : 'spanButtonPlaceholder',
				button_width: 160,
				button_height: 22,
				button_text: '<span class="button">Select Images <span class="buttonSmall">(2 MB Max)</span></span>',
				button_text_style : '.button { font-family: Helvetica, Arial, sans-serif; font-size: 14pt; } .buttonSmall { font-size: 10pt; }',
				button_text_top_padding: 1,
				button_text_left_padding: 5,

				// Flash Settings
				flash_url: '/assets/lib/swfupload/swfupload.swf',	// Relative to this file
				flash9_url: '/assets/lib/swfupload/swfupload_FP9.swf',	// Relative to this file

				custom_settings : {
					upload_target : 'divFileProgressContainer'
				},

				// Debug Settings
				debug: false
			});

           $('#btn_cut').click(function () {
               //alert('helen');             
                var $catch = $('#catch');
                var width = $catch.width();
                var height = $catch.height();
                var top = parseInt($catch.css('top'));
                var left = parseInt($catch.css('left'));
                $('#cut_img').css('display', 'block')
                $.post('/handler/file.ashx?action=cut', { width: width, height: height, top: top, left: left, file: imgSrc }, function(data) {
                    $('#cut_img').attr('src',data);
                });
                console.log(width);
            });
       
		}
       
	</script>
</head>
<body>
    <%--<form action="upload.aspx" method="post" enctype="multipart/form-data">
        <input type="file" name="file" value="" multiple="multiple"/><br />
        <input type="submit"/>
    </form>--%>
    <div id="swfu_container" style="margin: 0px 10px;">
		    <div>
				<span id="spanButtonPlaceholder"></span>
		    </div>
        <%--<div id="divFileProgressContainer" style="height: 75px;">--%>
                <%--<img id="img_src" src="#"/>--%>
		    <%--</div>--%>
		    <div id="thumbnails" style =" position:relative; overflow:hidden;">
                <div id="catch" style="display:none; position:absolute; width: 100px;height: 100px; border: 1px solid blue;">
                </div>              
		    </div>
       <input type="button"  id="btn_cut" value="截取" />
	   <img id="cut_img" src="#" style="display:none;"/>
    </div>
		    
        
</body>
</html>
