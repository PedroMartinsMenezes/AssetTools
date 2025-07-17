namespace AssetTool
{
    [JsonAsset("LyraWeaponSpawner")]
    public class ALyraWeaponSpawner : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}