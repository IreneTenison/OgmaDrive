//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace ogmaneo {

public class Vec2i : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vec2i(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vec2i obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vec2i() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csogmaneoPINVOKE.delete_Vec2i(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int x {
    set {
      csogmaneoPINVOKE.Vec2i_x_set(swigCPtr, value);
    } 
    get {
      int ret = csogmaneoPINVOKE.Vec2i_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      csogmaneoPINVOKE.Vec2i_y_set(swigCPtr, value);
    } 
    get {
      int ret = csogmaneoPINVOKE.Vec2i_y_get(swigCPtr);
      return ret;
    } 
  }

  public Vec2i() : this(csogmaneoPINVOKE.new_Vec2i__SWIG_0(), true) {
  }

  public Vec2i(int X, int Y) : this(csogmaneoPINVOKE.new_Vec2i__SWIG_1(X, Y), true) {
  }

}

}
