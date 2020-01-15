# Build Number Calculator

A little Windows tray tool calculating a build number based on the second of the day. Also has a "from yesterday" checkbox which allows continuing 
the build attemps after midnight without generating smaller build numbers. A bit after 4 am, the build number exceed the maximum value Windows allows
(65534). I recommend going to bed.

To fti 28 hours into 65534 values, the build number only increases every 1.54 seconds.

## Non-obvious usage

Clicking the build number copies it to the clipboard.

Clicking the time calculates a new build number based on the current time.