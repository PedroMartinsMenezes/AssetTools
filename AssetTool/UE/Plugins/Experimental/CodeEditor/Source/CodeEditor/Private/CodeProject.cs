namespace AssetTool
{
    [JsonAsset("CodeProject")]
    public class UCodeProject : UCodeProjectItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}