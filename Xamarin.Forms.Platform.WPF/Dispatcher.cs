﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.Platform.WPF
{
	public class Dispatcher : IDispatcher
	{
		public void BeginInvokeOnMainThread(Action action)
		{
			Device.BeginInvokeOnMainThread(action);
		}

		bool IDispatcher.IsInvokeRequired => Device.IsInvokeRequired;
	}
}
