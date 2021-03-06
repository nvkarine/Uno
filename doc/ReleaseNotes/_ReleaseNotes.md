# Release notes

## Next version

### Features

* 135799 Implemented MediaPlayer.Dispose()

### Breaking changes

* 132002 [Android] The collapsible button bar is now taken into account by visible bounds calculation. Apps which use VisibleBoundsPadding or have command bars will therefore see an adjustment to the height of their windows on Android.

### Bug fixes

 * 129762 - Updated Android SimpleOrientationSensor calculations based on SensorType.Gravity or based on single angle orientation when the device does not have a Gyroscope.
 * 134189 [iOS] The Time Picker flyout placement is not always respected
 * 134132 [Android] Fix loading of ItemsPresenter
 * 134104 [iOS] Fixed an issue when back swiping from a page with a collapsed CommandBar
 * 134026 [iOS] Setting a different DP from TextBox.TextChanging can cause an infinite 'ping pong' of changing Text values
 * 134415 [iOS] MenuFlyout was not loaded correctly, causing templates containing a MenuFlyout to fail
 * 133247 [iOS] Image performance improvements
 * 135192 [iOS] Fixed ImageBrush flash/flickering occurs when transitioning to a new page.
 * 135112 [Android] Fix crash in UpdateItemsPanelRoot() in the ItemsControl class.
 * 132014, 134103 [Android] Set the leading edge considering header can push groups out off the screen
 * 131998 [Android] Window bounds set too late
 * 131768 [iOS] Improve ListView.ScrollIntoView() when ItemTemplateSelector is set
 * 135202, 131884 [Android] Content occasionally fails to show because binding throws an exception
 * 135646 [Android] Binding MediaPlayerElement.Source causes video to go blank
 * 134819, 134828 [iOS] Ensures the back gesture is enabled and disabled properly when the CommandBar is visible, collapsed, visible with a navigation command and collapsed with a navigation command. 