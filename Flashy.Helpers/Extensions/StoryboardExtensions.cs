﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Flashy.Helpers.Extensions
{
    public static class StoryboardExtensions
    {
        public static Task BeginAsync(this Storyboard storyboard)
        {
            System.Threading.Tasks.TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            if (storyboard == null)
                tcs.SetException(new ArgumentNullException());
            else
            {
                EventHandler<object> onComplete = null;
                onComplete = (s, e) => {
                    storyboard.Completed -= onComplete;
                    tcs.SetResult(true);
                };
                storyboard.Completed += onComplete;
                storyboard.Begin();
            }
            return tcs.Task;
        }
    }
}
