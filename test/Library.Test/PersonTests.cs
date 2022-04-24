using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        /// <summary>
        /// Test para cuando el nombre es inválido, ya que devuelve basura.
        /// </summary>
        [Test]
        public void InvalidNameTest() // Cambiá el nombre para indicar qué estás probando
        {
            Person emptyName = new Person("", "5324939-0");
            Assert.IsNull(emptyName.Name);
            Assert.IsNotNull(emptyName.ID);
        }

        /// <summary>
        /// Test para cuando la cédula es inválida.
        /// </summary>
        [Test]
        public void InvalidIDTest()
        {
            Person emptyCI = new Person("John Doe", "");
            Assert.IsNull(emptyCI.ID);
            Assert.IsNotNull(emptyCI.Name);
        }

        /// <summary>
        /// Test para cuando el nombre es válido.
        /// </summary>
        [Test]
        public void ValidNameTest()
        {
            Person validName = new Person("John Doe", "");
            Assert.IsNotEmpty(validName.Name);
            Assert.IsNull(validName.ID);
        }

        /// <summary>
        /// Test para cuando la cédula es válida
        /// </summary>
        [Test]
        public void ValidIDTest()
        {
            Person validID = new Person("", "5324939-0");
            Assert.IsNotNull(validID.ID);
            Assert.IsNull(validID.Name);
        }

        /// <summary>
        /// Test para cuando ambos parámetros son válidos.
        /// </summary>
        [Test]
        public void ValidPersonTest()
        {
            Person valid = new Person("John Doe", "5324939-0");
            Assert.IsInstanceOf<Person>(valid);
        }
        
        /// <summary>
        /// Test para cuando ambos parámetros son validos.
        /// </summary>
        [Test]
        public void InValidPersonTest()
        {
            Person invalid = new Person("", "5324939");
            Assert.IsNull(invalid.Name);
            Assert.IsNull(invalid.ID);
        }
    }
}