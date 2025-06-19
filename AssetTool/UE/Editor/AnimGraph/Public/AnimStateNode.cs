namespace AssetTool
{
    [JsonAsset("AnimStateNode")]
    public class UAnimStateNode : UAnimStateNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}