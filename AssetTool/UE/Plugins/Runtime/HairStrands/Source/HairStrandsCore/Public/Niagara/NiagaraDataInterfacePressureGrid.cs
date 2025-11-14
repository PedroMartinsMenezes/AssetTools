namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfacePressureGrid")]
    public class UNiagaraDataInterfacePressureGrid : UNiagaraDataInterfaceVelocityGrid
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}