namespace AssetTool
{
    [Location("AttributeIdentifier.h bool Serialize(FArchive& Ar)")]
    public class FAnimationAttributeIdentifier
    {
        public const string StructName = "AnimationAttributeIdentifier";

        public FName Name;
        public FName BoneName;
        public Int32 BoneIndex;
        public FSoftObjectPath ScriptStructPath = new();

        public FAnimationAttributeIdentifier Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref BoneName);
            transfer.Move(ref BoneIndex);
            ScriptStructPath.Move(transfer);
            return this;
        }
    }
}
