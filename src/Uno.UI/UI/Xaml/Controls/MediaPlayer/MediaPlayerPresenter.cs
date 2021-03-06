#if __ANDROID__ || __IOS__
using System;
using Windows.Foundation;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
	public partial class MediaPlayerPresenter : Border
	{
		private double _currentRatio = 1;

		#region MediaPlayer Property

		public Windows.Media.Playback.MediaPlayer MediaPlayer
		{
			get { return (Windows.Media.Playback.MediaPlayer)GetValue(MediaPlayerProperty); }
			set { SetValue(MediaPlayerProperty, value); }
		}

		public static DependencyProperty MediaPlayerProperty { get; } =
			DependencyProperty.Register(
				nameof(MediaPlayer),
				typeof(Windows.Media.Playback.MediaPlayer),
				typeof(MediaPlayerPresenter),
				new FrameworkPropertyMetadata(default(Windows.Media.Playback.MediaPlayer), OnMediaPlayerChanged));

		private static void OnMediaPlayerChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
		{
			if (sender is MediaPlayerPresenter presenter)
			{
				if (args.OldValue is Windows.Media.Playback.MediaPlayer oldPlayer)
				{
					oldPlayer.VideoRatioChanged -= presenter.OnVideoRatioChanged;
				}

				if (args.NewValue is Windows.Media.Playback.MediaPlayer newPlayer)
				{
					newPlayer.VideoRatioChanged += presenter.OnVideoRatioChanged;
					presenter.SetVideoSurface(newPlayer.RenderSurface);
				}
			}
		}

		#endregion

		#region Stretch Property

		public Stretch Stretch
		{
			get { return (Stretch)GetValue(StretchProperty); }
			set { SetValue(StretchProperty, value); }
		}

		public static DependencyProperty StretchProperty { get; } =
			DependencyProperty.Register(
				nameof(Stretch),
				typeof(Stretch),
				typeof(MediaPlayerPresenter),
				new FrameworkPropertyMetadata(Stretch.Uniform, (s, e) => ((MediaPlayerPresenter)s).OnStretchChanged((Stretch)e.NewValue, (Stretch)e.OldValue)));

		#endregion

		#region IsFullWindow Property

		public bool IsFullWindow
		{
			get { return (bool)GetValue(IsFullWindowProperty); }
			set { SetValue(IsFullWindowProperty, value); }
		}

		public static DependencyProperty IsFullWindowProperty { get; } =
			DependencyProperty.Register(
				nameof(IsFullWindow),
				typeof(bool),
				typeof(MediaPlayerPresenter),
				new FrameworkPropertyMetadata(false));

		#endregion

		public MediaPlayerPresenter() : base()
		{
		}
		
		private void OnVideoRatioChanged(Windows.Media.Playback.MediaPlayer sender, double args)
		{
			_currentRatio = args;
			InvalidateArrange();
		}

		protected override Size MeasureOverride(Size availableSize)
		{
			if (double.IsNaN(Width) && double.IsNaN(Height))
			{
				availableSize.Width = availableSize.Width;
				availableSize.Height = availableSize.Width / _currentRatio;
			}
			else if (double.IsNaN(Width))
			{
				availableSize.Width = Height * _currentRatio;
				availableSize.Height = Height;
			}
			else if (double.IsNaN(Height))
			{
				availableSize.Width = Width;
				availableSize.Height = Width / _currentRatio;
			}
			
			base.MeasureOverride(availableSize);

			return availableSize;
		}
	}
}
#endif
