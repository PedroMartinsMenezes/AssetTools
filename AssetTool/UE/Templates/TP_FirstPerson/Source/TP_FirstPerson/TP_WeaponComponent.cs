namespace AssetTool
{
    [JsonAsset("TP_WeaponComponent")]
    public class UTP_WeaponComponent : USkeletalMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}