namespace AssetTool
{
    [JsonAsset("NavModifierVolume")]
    public class ANavModifierVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}