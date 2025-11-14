namespace AssetTool
{
    public class FRigBaseMetadata : FRigBaseMetadataValues, ITransferable
    {
        public FName Name;
        public ERigMetadataType Type;

        [Location("void FRigBaseMetadata.Serialize(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.MoveEnum(ref Type);
            GetMetadataStruct(transfer, Type);
            return this;
        }

        void GetMetadataStruct(Transfer transfer, ERigMetadataType InType)
        {
            switch (InType)
            {
                case ERigMetadataType.Bool:
                    transfer.Move(ref BoolValue);
                    break;
                case ERigMetadataType.BoolArray:
                    transfer.Move(ref BoolArray);
                    break;
                case ERigMetadataType.Float:
                    transfer.Move(ref FloatValue);
                    break;
                case ERigMetadataType.FloatArray:
                    transfer.Move(ref FloatArray);
                    break;
                case ERigMetadataType.Int32:
                    transfer.Move(ref Int32Value);
                    break;
                case ERigMetadataType.Int32Array:
                    transfer.Move(ref Int32Array);
                    break;
                case ERigMetadataType.Name:
                    transfer.Move(ref NameValue);
                    break;
                case ERigMetadataType.NameArray:
                    transfer.Move(ref NameArray);
                    break;
                case ERigMetadataType.Vector:
                    transfer.Move(ref VectorValue);
                    break;
                case ERigMetadataType.VectorArray:
                    transfer.Move(ref VectorArray);
                    break;
                case ERigMetadataType.Rotator:
                    transfer.Move(ref RotatorValue);
                    break;
                case ERigMetadataType.RotatorArray:
                    transfer.Move(ref RotatorArray);
                    break;
                case ERigMetadataType.Quat:
                    transfer.Move(ref QuatValue);
                    break;
                case ERigMetadataType.QuatArray:
                    transfer.Move(ref QuatArray);
                    break;
                case ERigMetadataType.Transform:
                    transfer.Move(ref TransformValue);
                    break;
                case ERigMetadataType.TransformArray:
                    transfer.Move(ref TransformArray);
                    break;
                case ERigMetadataType.LinearColor:
                    transfer.Move(ref LinearColorValue);
                    break;
                case ERigMetadataType.LinearColorArray:
                    transfer.Move(ref LinearColorArray);
                    break;
                case ERigMetadataType.RigElementKey:
                    transfer.Move(ref RigElementKeyValue);
                    break;
                case ERigMetadataType.RigElementKeyArray:
                    transfer.Move(ref RigElementKeyArray);
                    break;
            }
        }
    }

    public class FRigBaseMetadataValues
    {
        public FBool BoolValue;
        public FBool[] BoolArray;
        public float FloatValue;
        public float[] FloatArray;
        public Int32 Int32Value;
        public Int32[] Int32Array;
        public FName NameValue;
        public FName[] NameArray;
        public FVector VectorValue;
        public FVector[] VectorArray;
        public FRotator RotatorValue;
        public FRotator[] RotatorArray;
        public FQuat QuatValue;
        public FQuat[] QuatArray;
        public FTransform TransformValue;
        public FTransform[] TransformArray;
        public FLinearColor LinearColorValue;
        public FLinearColor[] LinearColorArray;
        public FRigElementKey RigElementKeyValue;
        public FRigElementKey[] RigElementKeyArray;
    }
}
