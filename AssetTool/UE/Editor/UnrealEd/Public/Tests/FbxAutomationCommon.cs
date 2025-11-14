namespace AssetTool
{
    [JsonAsset("FbxTestPlan")]
    public class UFbxTestPlan : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}