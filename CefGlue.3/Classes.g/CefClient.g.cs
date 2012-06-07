//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefClient
    {
        private static Dictionary<IntPtr, CefClient> _roots = new Dictionary<IntPtr, CefClient>();
        
        private int _refct;
        private cef_client_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        internal static CefClient FromNativeOrNull(cef_client_t* ptr)
        {
            CefClient value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefClient FromNative(cef_client_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_client_t.add_ref_delegate _ds0;
        private cef_client_t.release_delegate _ds1;
        private cef_client_t.get_refct_delegate _ds2;
        private cef_client_t.get_life_span_handler_delegate _ds3;
        private cef_client_t.get_load_handler_delegate _ds4;
        private cef_client_t.get_request_handler_delegate _ds5;
        private cef_client_t.get_display_handler_delegate _ds6;
        private cef_client_t.get_geolocation_handler_delegate _ds7;
        private cef_client_t.get_jsdialog_handler_delegate _ds8;
        private cef_client_t.get_context_menu_handler_delegate _ds9;
        private cef_client_t.on_process_message_recieved_delegate _dsa;
        
        protected CefClient()
        {
            _self = cef_client_t.Alloc();
        
            _ds0 = new cef_client_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_client_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_client_t.get_refct_delegate(get_refct);
            _self->_base._get_refct = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_client_t.get_life_span_handler_delegate(get_life_span_handler);
            _self->_get_life_span_handler = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_client_t.get_load_handler_delegate(get_load_handler);
            _self->_get_load_handler = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_client_t.get_request_handler_delegate(get_request_handler);
            _self->_get_request_handler = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_client_t.get_display_handler_delegate(get_display_handler);
            _self->_get_display_handler = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_client_t.get_geolocation_handler_delegate(get_geolocation_handler);
            _self->_get_geolocation_handler = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_client_t.get_jsdialog_handler_delegate(get_jsdialog_handler);
            _self->_get_jsdialog_handler = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_client_t.get_context_menu_handler_delegate(get_context_menu_handler);
            _self->_get_context_menu_handler = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_client_t.on_process_message_recieved_delegate(on_process_message_recieved);
            _self->_on_process_message_recieved = Marshal.GetFunctionPointerForDelegate(_dsa);
        }
        
        ~CefClient()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_client_t.Free(_self);
                _self = null;
            }
        }
        
        private int add_ref(cef_client_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
                return result;
            }
        }
        
        private int release(cef_client_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                }
                return result;
            }
        }
        
        private int get_refct(cef_client_t* self)
        {
            return _refct;
        }
        
        internal cef_client_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_client_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
