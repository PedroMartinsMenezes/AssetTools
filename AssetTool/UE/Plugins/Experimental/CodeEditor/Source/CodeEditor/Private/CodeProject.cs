namespace AssetTool
{
    [JsonAsset("CodeProject")]
    public class UCodeProject : UCodeProjectItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}