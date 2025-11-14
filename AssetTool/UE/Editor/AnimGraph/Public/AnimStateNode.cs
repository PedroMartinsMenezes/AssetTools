namespace AssetTool
{
    [JsonAsset("AnimStateNode")]
    public class UAnimStateNode : UAnimStateNodeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}