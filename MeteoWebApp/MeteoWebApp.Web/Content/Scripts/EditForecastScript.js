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
        var clickedButton = $(this);
        var id = clickedButton.attr('data');
        $('#edit-date-label').html($('#edit-date-data' + id).attr('data'));
        $('#edit-id-field').attr('value', clickedButton.attr('data'));
        $('#edit-temperature-field').attr('value', $('#edit-temperature-data' + id).attr('data'));
        $('#edit-rain-chance-field').attr('value', $('#edit-rain-chance-data' + id).attr('data'));
        $('#edit-wind-speed-field').attr('value', $('#edit-wind-speed-data' + id).attr('data'));
        var windDirection = $('#edit-wind-direction-data' + id).attr('data');
        $('#WindDirectionEdit').val(windDirection);
        var generalState = $('#edit-general-state-data' + id).attr('data');
        $('#GeneralStateEdit').val(generalState);
        if($('#edit-wind-speed-field').attr('value') == 0)
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
            $('#edit-wind-speed-field').attr('value', 0);
            $('#edit-wind-speed-field').attr('disabled', '');
        }
        else {
            $('#edit-wind-speed-field').removeAttr('disabled');
        }
    });

});