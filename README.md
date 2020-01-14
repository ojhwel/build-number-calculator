# Build Number Calculator

A little Windows tray tool calculating a build number that is the second of the day. This is the same build number Visual Studio generates for the
final segment of the version number if you set it to "x.x.x.*" but allows a little more control. Also has a "from yesterday" checkbox which allows
continuing the build attemps after midnight without generating smaller build numbers. After 03:46:39 a.m. the build number has six digits, at which
point I highly recommend going to bed.

## Non-obvious usage

Clicking the build number copies it to the clipboard.

Clicking the time calculates a new build number based on the current time.