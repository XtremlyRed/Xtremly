﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Xtremly.Core
{
    internal sealed class PopupInfo : IDisposable
    {
        private SemaphoreSlim SemaphoreSlim = new(0);
        private int semaphoreCounter;
        public PopupInfo(string hostName, PopupMode popupMode, string message, Func<IPopupContent> uIElementFunc, PopupConfig config = null)
        {
            PopupMode = popupMode;
            PopupConfig = config;
            Message = message;
            UIElementFunc = uIElementFunc;
            PopupHostName = hostName;
        }

        ~PopupInfo()
        {
            Dispose();
        }

        public bool PopupResult { get; set; }
        public string PopupHostName { get; }
        public PopupMode PopupMode { get; }
        public PopupConfig PopupConfig { get; private set; }
        public string Message { get; private set; }
        public Func<IPopupContent> UIElementFunc { get; private set; }
        public async Task<bool> DisplayAsync()
        {
            semaphoreCounter++;
            await SemaphoreSlim.WaitAsync();
            return PopupResult;
        }

        public void Close(bool result)
        {
            PopupResult = result;
            SemaphoreSlim.Release(semaphoreCounter);
            semaphoreCounter = 0;
        }

        public void Dispose()
        {
            semaphoreCounter = 0;
            UIElementFunc = null;
            Message = null;
            PopupConfig = null;
            SemaphoreSlim?.Dispose();
            SemaphoreSlim = null;
        }
    }

    [DebuggerDisplay("{HostName}")]
    [DebuggerNonUserCode]
    internal class PopupAware : IPopupAware
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private readonly Func<IPopupAware> popupPrivoder;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private string hostName = null;
        internal PopupAware(Func<IPopupAware> popupPrivoder, string popupHostName = null)
        {
            this.popupPrivoder = popupPrivoder ?? throw new ArgumentNullException(nameof(popupPrivoder));
            hostName = popupHostName;
        }

        public string HostName => hostName;
        public Task ShowAsync(string message, PopupConfig config = null)
        {
            IPopupAware popupHost = popupPrivoder();
            hostName = popupHost.HostName;
            return popupHost.ShowAsync(message, config);
        }
        public Task<bool> ConfirmAsync(string message, PopupConfig config = null)
        {
            IPopupAware popupHost = popupPrivoder();
            hostName = popupHost.HostName;
            return popupHost.ConfirmAsync(message, config);
        }

        public Task<bool> PopupAsync<Target>(Func<Target> uIElementFunc, PopupConfig config = null)
             where Target : UIElement, IPopupContent
        {
            IPopupAware popupHost = popupPrivoder();
            hostName = popupHost.HostName;
            return popupHost.PopupAsync<Target>(uIElementFunc, config);
        }
    }
}
