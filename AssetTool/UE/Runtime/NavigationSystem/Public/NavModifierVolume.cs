namespace AssetTool
{
    [JsonAsset("NavModifierVolume")]
    public class ANavModifierVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}