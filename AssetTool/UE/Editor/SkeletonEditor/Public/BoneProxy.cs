namespace AssetTool
{
    [JsonAsset("BoneProxy")]
    public class UBoneProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}