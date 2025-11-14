namespace AssetTool
{
    [JsonAsset("PCGRerouteSettings")]
    public class UPCGRerouteSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNamedRerouteBaseSettings")]
    public class UPCGNamedRerouteBaseSettings : UPCGRerouteSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNamedRerouteDeclarationSettings")]
    public class UPCGNamedRerouteDeclarationSettings : UPCGNamedRerouteBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNamedRerouteUsageSettings")]
    public class UPCGNamedRerouteUsageSettings : UPCGNamedRerouteBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}