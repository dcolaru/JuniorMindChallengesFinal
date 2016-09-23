using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class Flooring
    {
        [TestMethod]
        public void ParchetNecesar()
        {
            double totalParchet = CalculParchet(20, 10, 2, 1);
            Assert.AreEqual(115, totalParchet);
        }

        double CalculParchet(double roomLungime, double roomLatime, double placaLungime, double placaLatime)
        {
            double suprafataPlaca = placaLungime * placaLatime;
            double suprafataRoom = roomLungime * roomLatime;

            double totalParchet = suprafataRoom / suprafataPlaca + ((suprafataRoom / suprafataPlaca) * 0.15);

            return totalParchet;
        }
    }
}
