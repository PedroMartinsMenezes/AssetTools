namespace AssetTool
{
    [JsonAsset("TDM_PlayerSpawningManagmentComponent")]
    public class UTDM_PlayerSpawningManagmentComponent : ULyraPlayerSpawningManagerComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}