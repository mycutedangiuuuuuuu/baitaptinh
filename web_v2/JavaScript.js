$(document).ready(function () {
    function sendData() {
        var dai = $('#txtA').val();
        var rong = $('#txtB').val();

        if (isNaN(dai) || isNaN(rong) ) {
            alert('Vui lòng nhập giá trị hợp lệ cho hai cạnh.');
            return;
        }

        var dataToSend = {
            chieudai: dai,
            chieurong : rong,
        };

        $.ajax({
            url: "WebForm1.aspx",
            type: "POST",
            data: JSON.stringify(dataToSend),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                $('#lblResult').html('Diện tích hình chữ nhật là: ' + response.dientich + '<br>' + 'Chu vi hình chữ nhật là :' + response.chuvi);
            },
            error: function (xhr, status, error) {
                $('#lblResult').text('Có lỗi xảy ra: ' + xhr.responseText);
            }
        });
    }

    $("#btnCalculate").click(function () {
        sendData();
    });
});
