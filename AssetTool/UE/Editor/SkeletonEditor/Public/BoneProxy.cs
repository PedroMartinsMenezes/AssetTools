namespace AssetTool
{
    [JsonAsset("BoneProxy")]
    public class UBoneProxy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}