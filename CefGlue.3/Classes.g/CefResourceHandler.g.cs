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
    public abstract unsafe partial class CefResourceHandler
    {
        private static Dictionary<IntPtr, CefResourceHandler> _roots = new Dictionary<IntPtr, CefResourceHandler>();
        
        private int _refct;
        private cef_resource_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_resource_handler_t.add_ref_delegate _ds0;
        private cef_resource_handler_t.release_delegate _ds1;
        private cef_resource_handler_t.get_refct_delegate _ds2;
        private cef_resource_handler_t.process_request_delegate _ds3;
        private cef_resource_handler_t.get_response_headers_delegate _ds4;
        private cef_resource_handler_t.read_response_delegate _ds5;
        private cef_resource_handler_t.cancel_delegate _ds6;
        
        protected CefResourceHandler()
        {
            _self = cef_resource_handler_t.Alloc();
        
            _ds0 = new cef_resource_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_resource_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_resource_handler_t.get_refct_delegate(get_refct);
            _self->_base._get_refct = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_resource_handler_t.process_request_delegate(process_request);
            _self->_process_request = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_resource_handler_t.get_response_headers_delegate(get_response_headers);
            _self->_get_response_headers = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_resource_handler_t.read_response_delegate(read_response);
            _self->_read_response = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_resource_handler_t.cancel_delegate(cancel);
            _self->_cancel = Marshal.GetFunctionPointerForDelegate(_ds6);
        }
        
        ~CefResourceHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_resource_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private int add_ref(cef_resource_handler_t* self)
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
        
        private int release(cef_resource_handler_t* self)
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
        
        private int get_refct(cef_resource_handler_t* self)
        {
            return _refct;
        }
        
        internal cef_resource_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_resource_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
