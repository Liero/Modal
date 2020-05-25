using System;
using Microsoft.AspNetCore.Components;

namespace Blazored.Modal.Services
{
    public interface IModalService
    {

        /// <summary>
        /// Shows the modal with the component type.
        /// </summary>
        public ModalReference Show<T>() where T : ComponentBase
        {
            return Show<T>(string.Empty, new ModalParameters(), new ModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="title">Modal title.</param>
        public ModalReference Show<T>(string title) where T : ComponentBase
        {
            return Show<T>(title, new ModalParameters(), new ModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="options">Options to configure the modal.</param>
        public ModalReference Show<T>(string title, ModalOptions options) where T : ComponentBase
        {
            return Show<T>(title, new ModalParameters(), options);
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>,
        /// passing the specified <paramref name="parameters"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        public ModalReference Show<T>(string title, ModalParameters parameters) where T : ComponentBase
        {
            return Show<T>(title, parameters, new ModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>,
        /// passing the specified <paramref name="parameters"/> and setting a custom CSS style.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        public ModalReference Show<T>(string title, ModalParameters parameters, ModalOptions options) where T : ComponentBase
        {
            return Show(typeof(T), title, parameters, options);
        }

        /// <summary>
        /// Shows the modal with the specific component type.
        /// </summary>
        /// <param name="contentComponent">Type of component to display.</param>
        public ModalReference Show(Type contentComponent)
        {
            return Show(contentComponent, string.Empty, new ModalParameters(), new ModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="contentComponent">Type of component to display.</param>
        /// <param name="title">Modal title.</param>
        public ModalReference Show(Type contentComponent, string title)
        {
            return Show(contentComponent, title, new ModalParameters(), new ModalOptions());
        }

        /// <summary>
        /// Shows the modal with the component type using the specified title.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="contentComponent">Type of component to display.</param>
        /// <param name="options">Options to configure the modal.</param>
        public ModalReference Show(Type contentComponent, string title, ModalOptions options)
        {
            return Show(contentComponent, title, new ModalParameters(), options);
        }

        /// <summary>
        /// Shows the modal with the component type using the specified <paramref name="title"/>,
        /// passing the specified <paramref name="parameters"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="contentComponent">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        public ModalReference Show(Type contentComponent, string title, ModalParameters parameters)
        {
            return Show(contentComponent, title, parameters, new ModalOptions());
        }

        /// <summary>
        /// Shows a modal containing a <paramref name="component"/> with the specified <paramref name="title"/>, <paramref name="parameters"/>
        /// and <paramref name="options"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        ModalReference Show(Type component, string title, ModalParameters parameters, ModalOptions options);
    }
}
