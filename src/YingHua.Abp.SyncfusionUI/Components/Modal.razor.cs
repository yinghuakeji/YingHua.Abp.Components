using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs;
using Volo.Abp.AspNetCore.Components.Progression;

namespace YingHua.Abp.SyncfusionUI.Components
{
    public class ModalClosingEventArgs : CancelEventArgs
    {
        public ModalClosingEventArgs(bool cancel, CloseReason closeReason)

        {
            this.Cancel = cancel;
            this.CloseReason = closeReason;
        }

        /// <summary>
        /// Gets a value that indicates why the modal is being closed.
        /// </summary>
        public CloseReason CloseReason { get; }
    }
    public enum CloseReason
    {
        /// <summary>
        /// The cause of the closure was not defined or could not be determined.
        /// </summary>
        None,
        /// <summary>
        /// The user is closing the component through the user interface.
        /// </summary>
        UserClosing,
        /// <summary>
        /// The component has lost focus or user has gone out of bounds.
        /// </summary>
        FocusLostClosing,
        /// <summary>Pressing the escape key is closing the component.</summary>
        EscapeClosing,
    }
    public partial class Modal : ComponentBase, IDisposable
    {
        protected bool Disposed { get; private set; }
     
        /// <inheritdoc />
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize((object)this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:Blazorise.BaseComponent" /> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">True if the component is in the disposing process.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this.Disposed)
                return;
            this.Disposed = true;
            if (!disposing)
                return;
           
        }
        public void Hide() => this.Hide(CloseReason.UserClosing);

        public void Show()
        {
            throw new NotImplementedException();
        }

        protected internal void Hide(CloseReason closeReason)
        {
             
        }
    }
}
