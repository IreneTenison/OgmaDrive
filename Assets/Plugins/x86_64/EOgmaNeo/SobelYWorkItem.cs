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

public class SobelYWorkItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SobelYWorkItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SobelYWorkItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SobelYWorkItem() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_SobelYWorkItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public StdVecf _psrc {
    set {
      eogmaneoPINVOKE.SobelYWorkItem__psrc_set(swigCPtr, StdVecf.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = eogmaneoPINVOKE.SobelYWorkItem__psrc_get(swigCPtr);
      StdVecf ret = (cPtr == global::System.IntPtr.Zero) ? null : new StdVecf(cPtr, false);
      return ret;
    } 
  }

  public StdVecf _pdest {
    set {
      eogmaneoPINVOKE.SobelYWorkItem__pdest_set(swigCPtr, StdVecf.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = eogmaneoPINVOKE.SobelYWorkItem__pdest_get(swigCPtr);
      StdVecf ret = (cPtr == global::System.IntPtr.Zero) ? null : new StdVecf(cPtr, false);
      return ret;
    } 
  }

  public int _cx {
    set {
      eogmaneoPINVOKE.SobelYWorkItem__cx_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.SobelYWorkItem__cx_get(swigCPtr);
      return ret;
    } 
  }

  public int _cy {
    set {
      eogmaneoPINVOKE.SobelYWorkItem__cy_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.SobelYWorkItem__cy_get(swigCPtr);
      return ret;
    } 
  }

  public int _width {
    set {
      eogmaneoPINVOKE.SobelYWorkItem__width_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.SobelYWorkItem__width_get(swigCPtr);
      return ret;
    } 
  }

  public int _chunkSize {
    set {
      eogmaneoPINVOKE.SobelYWorkItem__chunkSize_set(swigCPtr, value);
    } 
    get {
      int ret = eogmaneoPINVOKE.SobelYWorkItem__chunkSize_get(swigCPtr);
      return ret;
    } 
  }

  public SobelYWorkItem() : this(eogmaneoPINVOKE.new_SobelYWorkItem(), true) {
  }

  public void run(uint threadIndex) {
    eogmaneoPINVOKE.SobelYWorkItem_run(swigCPtr, threadIndex);
  }

}

}
