namespace AssetTool
{
    public class FRigElementKey : ITransferible
    {
        public FName TypeName;
        public FName Name;
        public ERigElementType Type;

        [Location("void FRigElementKey::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref TypeName);

            Type = (ERigElementType)Enum.Parse(typeof(ERigElementType), TypeName.Value.Split("::")[1]);

            transfer.Move(ref Name);
            return this;
        }
    }

    public class FRigControlLimitEnabled : ITransferible
    {
        public FBool bMinimum;
        public FBool bMaximum;

        [Location("void FRigControlLimitEnabled::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bMinimum);
            transfer.Move(ref bMaximum);
            return this;
        }
    }
    public class FRigControlValue : ITransferible
    {
        public FRigControlValueStorage FloatStorage;

        [Location("FArchive& operator<<(FArchive& Ar, FRigControlValue& Value)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref FloatStorage);
            return this;
        }
    }

    public class FRigControlValueStorage : ITransferible
    {
        public float Float00;
        public float Float01;
        public float Float02;
        public float Float03;
        public float Float10;
        public float Float11;
        public float Float12;
        public float Float13;
        public float Float20;
        public float Float21;
        public float Float22;
        public float Float23;
        public float Float30;
        public float Float31;
        public float Float32;
        public float Float33;
        public float Float00_2;
        public float Float01_2;
        public float Float02_2;
        public float Float03_2;
        public float Float10_2;
        public float Float11_2;
        public float Float12_2;
        public float Float13_2;
        public float Float20_2;
        public float Float21_2;
        public float Float22_2;
        public float Float23_2;
        public float Float30_2;
        public float Float31_2;
        public float Float32_2;
        public float Float33_2;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Float00);
            transfer.Move(ref Float01);
            transfer.Move(ref Float02);
            transfer.Move(ref Float03);
            transfer.Move(ref Float10);
            transfer.Move(ref Float11);
            transfer.Move(ref Float12);
            transfer.Move(ref Float13);
            transfer.Move(ref Float20);
            transfer.Move(ref Float21);
            transfer.Move(ref Float22);
            transfer.Move(ref Float23);
            transfer.Move(ref Float30);
            transfer.Move(ref Float31);
            transfer.Move(ref Float32);
            transfer.Move(ref Float33);
            transfer.Move(ref Float00_2);
            transfer.Move(ref Float01_2);
            transfer.Move(ref Float02_2);
            transfer.Move(ref Float03_2);
            transfer.Move(ref Float10_2);
            transfer.Move(ref Float11_2);
            transfer.Move(ref Float12_2);
            transfer.Move(ref Float13_2);
            transfer.Move(ref Float20_2);
            transfer.Move(ref Float21_2);
            transfer.Move(ref Float22_2);
            transfer.Move(ref Float23_2);
            transfer.Move(ref Float30_2);
            transfer.Move(ref Float31_2);
            transfer.Move(ref Float32_2);
            transfer.Move(ref Float33_2);
            return this;
        }
    }

    public enum ERigMetadataType : byte
    {
        Bool,
        BoolArray,
        Float,
        FloatArray,
        Int32,
        Int32Array,
        Name,
        NameArray,
        Vector,
        VectorArray,
        Rotator,
        RotatorArray,
        Quat,
        QuatArray,
        Transform,
        TransformArray,
        LinearColor,
        LinearColorArray,
        RigElementKey,
        RigElementKeyArray,
        Invalid
    }

    public enum ERigElementType : byte
    {
        None,
        Bone = 0x001,
        Null = 0x002,
        Space = Null,
        Control = 0x004,
        Curve = 0x008,
        RigidBody = 0x010,
        Reference = 0x020,
        Last = 0x040,
        All = Bone | Null | Control | Curve | RigidBody | Reference,
        ToResetAfterConstructionEvent = Bone | Control | Curve
    }
}
