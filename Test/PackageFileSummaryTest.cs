using AssetTool.Model;
using AssetTool.Service;

namespace AssetTool.Test
{
    public static class PackageFileSummaryTest
    {
        public static FPackageFileSummary GetPackageFileSummary()
        {
            var Sum = new FPackageFileSummary();

            Sum.Tag = -1641380927;

            Sum.LegacyFileVersion = -8;
            Sum.LegacyUE3Version = 864;

            Sum.FileVersionUE.FileVersionUE4 = 522;
            Sum.FileVersionUE.FileVersionUE5 = 1009;
            Sum.FileVersionLicenseeUE = 0;

            Sum.CustomVersionContainer.Add(04, "375EC13C-06E4-48FB-B500-84F0262A717E");
            Sum.CustomVersionContainer.Add(37, "CFFC743F-43B0-4480-9391-14DF171D2073");
            Sum.CustomVersionContainer.Add(47, "D89B5E42-24BD-4D46-8412-ACA8DF641779");
            Sum.CustomVersionContainer.Add(40, "E4B068ED-F494-42E9-A231-DA0B2E46BB41");

            Sum.TotalHeaderSize = 2777;
            Sum.PackageName = "/Game/Lab/S_Endereco";

            return Sum;
        }

        public static void SaveStruct()
        {
            var Sum = GetPackageFileSummary();
            var service = new PackageFileSummaryService();
            service.Save("C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco2.dat", Sum);
        }
    }
}
