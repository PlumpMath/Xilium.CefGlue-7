//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_browser_host_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_browser;
        internal IntPtr _parent_window_will_close;
        internal IntPtr _close_browser;
        internal IntPtr _set_focus;
        internal IntPtr _get_window_handle;
        internal IntPtr _get_opener_window_handle;
        internal IntPtr _get_client;
        internal IntPtr _get_dev_tools_url;
        
        // CreateBrowser
        [DllImport(libcef.DllName, EntryPoint = "cef_browser_host_create_browser", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_browser(cef_window_info_t* windowInfo, cef_client_t* client, cef_string_t* url, cef_browser_settings_t* settings);
        
        // CreateBrowserSync
        [DllImport(libcef.DllName, EntryPoint = "cef_browser_host_create_browser_sync", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_browser_t* create_browser_sync(cef_window_info_t* windowInfo, cef_client_t* client, cef_string_t* url, cef_browser_settings_t* settings);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_browser_t* get_browser_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void parent_window_will_close_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void close_browser_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_focus_delegate(cef_browser_host_t* self, int enable);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate IntPtr get_window_handle_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate IntPtr get_opener_window_handle_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_client_t* get_client_delegate(cef_browser_host_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_dev_tools_url_delegate(cef_browser_host_t* self, int http_scheme);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_browser_host_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            return d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_browser_host_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static get_refct_delegate _d2;
        
        public static int get_refct(cef_browser_host_t* self)
        {
            get_refct_delegate d;
            var p = self->_base._get_refct;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (get_refct_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_refct_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // GetBrowser
        private static IntPtr _p3;
        private static get_browser_delegate _d3;
        
        public static cef_browser_t* get_browser(cef_browser_host_t* self)
        {
            get_browser_delegate d;
            var p = self->_get_browser;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (get_browser_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_browser_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // ParentWindowWillClose
        private static IntPtr _p4;
        private static parent_window_will_close_delegate _d4;
        
        public static void parent_window_will_close(cef_browser_host_t* self)
        {
            parent_window_will_close_delegate d;
            var p = self->_parent_window_will_close;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (parent_window_will_close_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(parent_window_will_close_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            d(self);
        }
        
        // CloseBrowser
        private static IntPtr _p5;
        private static close_browser_delegate _d5;
        
        public static void close_browser(cef_browser_host_t* self)
        {
            close_browser_delegate d;
            var p = self->_close_browser;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (close_browser_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(close_browser_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self);
        }
        
        // SetFocus
        private static IntPtr _p6;
        private static set_focus_delegate _d6;
        
        public static void set_focus(cef_browser_host_t* self, int enable)
        {
            set_focus_delegate d;
            var p = self->_set_focus;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (set_focus_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_focus_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            d(self, enable);
        }
        
        // GetWindowHandle
        private static IntPtr _p7;
        private static get_window_handle_delegate _d7;
        
        public static IntPtr get_window_handle(cef_browser_host_t* self)
        {
            get_window_handle_delegate d;
            var p = self->_get_window_handle;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_window_handle_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_window_handle_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetOpenerWindowHandle
        private static IntPtr _p8;
        private static get_opener_window_handle_delegate _d8;
        
        public static IntPtr get_opener_window_handle(cef_browser_host_t* self)
        {
            get_opener_window_handle_delegate d;
            var p = self->_get_opener_window_handle;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_opener_window_handle_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_opener_window_handle_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // GetClient
        private static IntPtr _p9;
        private static get_client_delegate _d9;
        
        public static cef_client_t* get_client(cef_browser_host_t* self)
        {
            get_client_delegate d;
            var p = self->_get_client;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_client_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_client_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // GetDevToolsURL
        private static IntPtr _pa;
        private static get_dev_tools_url_delegate _da;
        
        public static cef_string_userfree* get_dev_tools_url(cef_browser_host_t* self, int http_scheme)
        {
            get_dev_tools_url_delegate d;
            var p = self->_get_dev_tools_url;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_dev_tools_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_dev_tools_url_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self, http_scheme);
        }
        
    }
}
