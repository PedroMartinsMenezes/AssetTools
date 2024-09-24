namespace AssetTool
{
    [StructSerializable("AnimationAttributeIdentifier")]
    public class FAnimationAttributeIdentifier : ITransferible
    {
        public const string StructName = "AnimationAttributeIdentifier";

        public FName Name;
        public FName BoneName;
        public Int32 BoneIndex;
        public FSoftObjectPath ScriptStructPath = new();

        [Location("AttributeIdentifier.h bool Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref BoneName);
            transfer.Move(ref BoneIndex);
            ScriptStructPath.Move(transfer);
            return this;
        }
    }
}
