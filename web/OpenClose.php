
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/menu.css"/>
</head>
<body>
    


</body>
</html>

<?php
date_default_timezone_set('Europe/Amsterdam');

$storeSchedule = [
    'Mon' => ['09:00' => '14:40'],
    'Tue' => ['09:00' => '14:35'],
    'Wed' => ['09:00' => '18:40'],
    'Thu' => ['09:00' => '14:40'],
    'Fri' => ['09:00' => '14:40'],
    'Sat' => ['09:00' => '14:40']
];

$timestamp = time();

// default status
$status = 'Gesloten';

// get current time object
$currentTime = (new DateTime())->setTimestamp($timestamp);

// loop through time ranges for current day
foreach ($storeSchedule[date('D', $timestamp)] as $startTime => $endTime) {

    // create time objects from start/end times
    $startTime = DateTime::createFromFormat('h:i A', $startTime);
    $endTime   = DateTime::createFromFormat('h:i A', $endTime);

    // check if current time is within a range
    if (($startTime < $currentTime) && ($currentTime < $endTime)) {
        $status = 'open';
        break;
    }
}
echo '<div class="shopOpenClose">';
echo "Wij zijn nu: $status";
echo '</div>';

?>