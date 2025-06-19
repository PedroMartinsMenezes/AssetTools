namespace AssetTool
{
    [JsonAsset("NavModifierVolume")]
    public class ANavModifierVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}