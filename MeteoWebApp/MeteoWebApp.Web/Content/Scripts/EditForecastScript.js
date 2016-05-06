$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
    $('.delete-button').click(function () {
        var clickedDeleteButton = $(this);
        $('#delete-id-field').attr('value', clickedDeleteButton.attr('data'));
    });
    $('.create-button').click(function () {
        $('#create-validation-failed-warning').html("");
        $('#create-temperature-field').val(0);
        $('#create-rain-chance-field').val(0);
        $('#create-wind-speed-field').val(0);
        $('#WindDirection').val(1);
        $('#GeneralState').val(1);
        var clickedCreateButton = $(this);
        $('#create-date-field').val(clickedCreateButton.attr('data'));
        $('#create-date-label').html(clickedCreateButton.attr('data'));
    });
    $('#WindDirection').change(function () {
        if ($('#WindDirection').val() == 9) {
            $('#create-wind-speed-field').val(0);
            $('#create-wind-speed-field').attr('disabled', '');
        }
        else {
            $('#create-wind-speed-field').removeAttr('disabled');
        }
    });
    $('.edit-button').click(function () {
        $('#edit-validation-failed-warning').html("");
        var clickedButton = $(this);
        var id = clickedButton.attr('data');
        $('#edit-date-label').html($('#edit-date-data' + id).attr('data'));
        $('#edit-id-field').val(clickedButton.attr('data'));
        $('#edit-temperature-field').val($('#edit-temperature-data' + id).attr('data'));
        $('#edit-rain-chance-field').val($('#edit-rain-chance-data' + id).attr('data'));
        $('#edit-wind-speed-field').val($('#edit-wind-speed-data' + id).attr('data'));
        var windDirection = $('#edit-wind-direction-data' + id).attr('data');
        $('#WindDirectionEdit').val(windDirection);
        var generalState = $('#edit-general-state-data' + id).attr('data');
        $('#GeneralStateEdit').val(generalState);
        if($('#edit-wind-speed-field').val() == 0)
        {
            $('#edit-wind-speed-field').attr('disabled', '');
        }
        else
        {
            $('#edit-wind-speed-field').removeAttr('disabled');
        }
    });
    $('#WindDirectionEdit').change(function () {
        if ($('#WindDirectionEdit option:selected').val() == 9) {
            $('#edit-wind-speed-field').val(0);
            $('#edit-wind-speed-field').attr('disabled', '');
        }
        else {
            $('#edit-wind-speed-field').removeAttr('disabled');
        }
    });
});