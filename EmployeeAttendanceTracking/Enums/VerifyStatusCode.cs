using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Enums
{
    /// <summary>
    /// Butun operasyonlarda dogrulama kodu olarak kullanilir.
    /// 0 Harici başarısız kabul edilir.
    /// </summary>
    public enum VerifyStatusCode
    {
        /// <summary>
        /// Başarılı
        /// </summary>
        Success = 0,
        /// <summary>
        /// Kullanıcı bulunamadı
        /// </summary>
        NotFound = 1,
        /// <summary>
        /// Kullanıcının biyometrik kaydı yok
        /// </summary>
        NotEnrolled = 2,
        /// <summary>
        /// Kullanıcının biyometrik tipi geçersiz
        /// </summary>
        NotAllowedBioType = 3,
        /// <summary>
        /// Kullanıcı doğrulanamadı
        /// </summary>
        NotVerified = 4,
        /// <summary>
        /// Ziyaretçi yada Kullanıcı için Kart desteklenmiyor.
        /// </summary>
        CardNotSupported = 5,
    }
}
