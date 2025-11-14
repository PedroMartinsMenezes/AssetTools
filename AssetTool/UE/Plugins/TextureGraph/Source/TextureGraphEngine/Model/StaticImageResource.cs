namespace AssetTool
{
    [JsonAsset("StaticImageResource")]
    public class UStaticImageResource : UModelObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}