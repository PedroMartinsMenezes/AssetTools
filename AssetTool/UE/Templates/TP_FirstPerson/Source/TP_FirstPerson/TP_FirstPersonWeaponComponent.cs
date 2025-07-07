namespace AssetTool
{
    [JsonAsset("TP_FirstPersonWeaponComponent")]
    public class UTP_FirstPersonWeaponComponent : USkeletalMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}