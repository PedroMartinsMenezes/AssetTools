namespace AssetTool
{
    [JsonAsset("FbxTestPlan")]
    public class UFbxTestPlan : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}