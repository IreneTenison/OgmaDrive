//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class Caret : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Caret(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Caret obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Caret() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_Caret(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_sf__Uint16 _layer {
    set {
      eogmaneoPINVOKE.Caret__layer_set(swigCPtr, SWIGTYPE_p_sf__Uint16.getCPtr(value));
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_sf__Uint16 ret = new SWIGTYPE_p_sf__Uint16(eogmaneoPINVOKE.Caret__layer_get(swigCPtr), true);
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_sf__Uint16 _bitIndex {
    set {
      eogmaneoPINVOKE.Caret__bitIndex_set(swigCPtr, SWIGTYPE_p_sf__Uint16.getCPtr(value));
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_sf__Uint16 ret = new SWIGTYPE_p_sf__Uint16(eogmaneoPINVOKE.Caret__bitIndex_get(swigCPtr), true);
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Caret() : this(eogmaneoPINVOKE.new_Caret(), true) {
  }

}

}
