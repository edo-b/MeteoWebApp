$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
    $('.delete-button').click(function () {
        var clickedDeleteButton = $(this);
        $('#delete-id-field').attr('value', clickedDeleteButton.attr('data'));
    });
    $('.create-button').click(function () {
        var clickedCreateButton = $(this);
        $('#create-date-field').attr('value', clickedCreateButton.attr('data'));
        $('#create-date-label').html(clickedCreateButton.attr('data'));
    });
    $('#WindDirection').change(function () {
        if ($('#WindDirection option:selected').val() == 9) {
            $('#wind-speed-input-field').attr('value', 0);
            $('#wind-speed-input-field').attr('disabled', '');
        }
        else {
            $('#wind-speed-input-field').removeAttr('disabled');
        }
    });
    $('.edit-button').click(function () {

    });
    $('#WindDirectionEdit').change(function () {
        if ($('#WindDirectionEdit option:selected').val() == 9) {
            $('#wind-speed-edit-input-field').attr('value', 0);
            $('#wind-speed-edit-input-field').attr('disabled', '');
        }
        else {
            $('#wind-speed-edit-input-field').removeAttr('disabled');
        }
    });

});