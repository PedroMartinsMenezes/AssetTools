namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfacePressureGrid")]
    public class UNiagaraDataInterfacePressureGrid : UNiagaraDataInterfaceVelocityGrid
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}