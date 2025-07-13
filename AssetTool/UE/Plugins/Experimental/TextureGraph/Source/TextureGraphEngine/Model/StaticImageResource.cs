namespace AssetTool
{
    [JsonAsset("StaticImageResource")]
    public class UStaticImageResource : UModelObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}