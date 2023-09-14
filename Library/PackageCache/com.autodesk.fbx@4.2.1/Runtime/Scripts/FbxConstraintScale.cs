#if UNITY_EDITOR || FBXSDK_RUNTIME
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxConstraintScale : FbxConstraint {
  internal FbxConstraintScale(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxConstraintScale Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxConstraintScale_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxConstraintScale ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintScale(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxConstraintScale Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxConstraintScale_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxConstraintScale ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintScale(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyBool AffectX {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintScale_AffectX_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectY {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintScale_AffectY_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectZ {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintScale_AffectZ_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyDouble3 Scaling {
    get {
      FbxPropertyDouble3 ret = new FbxPropertyDouble3(NativeMethods.FbxConstraintScale_Scaling_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void AddConstraintSource(FbxObject pObject, double pWeight) {
    NativeMethods.FbxConstraintScale_AddConstraintSource__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pWeight);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void AddConstraintSource(FbxObject pObject) {
    NativeMethods.FbxConstraintScale_AddConstraintSource__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetConstrainedObject(FbxObject pObject) {
    NativeMethods.FbxConstraintScale_SetConstrainedObject(swigCPtr, FbxObject.getCPtr(pObject));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxConstraintScale other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxConstraintScale;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxConstraintScale).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxConstraintScale a, FbxConstraintScale b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxConstraintScale a, FbxConstraintScale b) {
    return !(a == b);
  }

}

}

#endif // UNITY_EDITOR || FBXSDK_RUNTIME