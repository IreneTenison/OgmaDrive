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

public class CornerEncoderWorkItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CornerEncoderWorkItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CornerEncoderWorkItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CornerEncoderWorkItem() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_CornerEncoderWorkItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CornerEncoder _pEncoder {
    set {
      eogmaneoPINVOKE.CornerEncoderWorkItem__pEncoder_set(swigCPtr, CornerEncoder.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = eogmaneoPINVOKE.CornerEncoderWorkItem__pEncoder_get(swigCPtr);
      CornerEncoder ret = (cPtr == global::System.IntPtr.Zero) ? null : new CornerEncoder(cPtr, false);
      return ret;
    } 
  }

  public int _cx {
    set {
      eogmaneoPINVOKE.CornerEncoderWorkItem__cx_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.CornerEncoderWorkItem__cx_get(swigCPtr);
      return ret;
    } 
  }

  public int _cy {
    set {
      eogmaneoPINVOKE.CornerEncoderWorkItem__cy_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.CornerEncoderWorkItem__cy_get(swigCPtr);
      return ret;
    } 
  }

  public bool _useDistanceMetric {
    set {
      eogmaneoPINVOKE.CornerEncoderWorkItem__useDistanceMetric_set(swigCPtr, value);
    } 
    get {
      bool ret = eogmaneoPINVOKE.CornerEncoderWorkItem__useDistanceMetric_get(swigCPtr);
      return ret;
    } 
  }

  public CornerEncoderWorkItem() : this(eogmaneoPINVOKE.new_CornerEncoderWorkItem(), true) {
  }

  public void run(uint threadIndex) {
    eogmaneoPINVOKE.CornerEncoderWorkItem_run(swigCPtr, threadIndex);
  }

}

}