using System.Diagnostics;

namespace ProductManager
{
    public class Manager
    {
        const int CAPACITY = 128;

        private static Manager mInstance;
        public static Manager Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new Manager();
                }

                return mInstance;
            }
        }

        private PriorityQueue<Product, DateTime> mProducts;

        private Manager()
        {
            mProducts = new PriorityQueue<Product, DateTime>(CAPACITY);

            Product product0 = new Product("한쌈김밥", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product0, product0.Date);

            Product product1 = new Product("햄에그모닝머핀", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product1, product1.Date);

            Product product2 = new Product("트리플포크김밥", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product2, product2.Date);

            Product product3 = new Product("뉴리치소고기전주", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product3, product3.Date);

            Product product4 = new Product("에그포테이토", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product4, product4.Date);

            Product product5 = new Product("시그니처제육구이정식", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product5, product5.Date);

            Product product6 = new Product("백종원트리플스페셜", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product6, product6.Date);

            Product product7 = new Product("스팸데리마요밥바", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product7, product7.Date);

            Product product8 = new Product("참치마요&전주비빔", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product8, product8.Date);

            Product product9 = new Product("통리챔참치마요", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product9, product9.Date);

            Product product10 = new Product("소불고기정식", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product10, product10.Date);

            Product product11 = new Product("계란김밥", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product11, product11.Date);

            Product product12 = new Product("리챔김치볶음", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product12, product12.Date);

            Product product13 = new Product("백종원열탄불고기김밥", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product13, product13.Date);

            Product product14 = new Product("하프앤하프", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product14, product14.Date);

            Product product15 = new Product("통밀햄", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product15, product15.Date);

            Product product16 = new Product("시그니처가라아게정식", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product16, product16.Date);

            Product product17 = new Product("주종발효허니카스테라", new DateTime(2023, 4, 24));
            mProducts.Enqueue(product17, product17.Date);

            Product product18 = new Product("포켓몬님파이의딸기콕콕초코브라우니", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product18, product18.Date);

            Product product19 = new Product("점보치즈불고기", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product19, product19.Date);

            Product product20 = new Product("408시간주종발효카스타드소보루", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product20, product20.Date);

            Product product21 = new Product("장자미니족발", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product21, product21.Date);

            Product product22 = new Product("포비빅단팥행운빵", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product22, product22.Date);

            Product product23 = new Product("연세우유황치즈생크림빵", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product23, product23.Date);

            Product product24 = new Product("매점고로케딥치즈치킨", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product24, product24.Date);

            Product product25 = new Product("매점고로케치킨모짜", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product25, product25.Date);

            Product product26 = new Product("종가집썰어담은맛김치", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product26, product26.Date);

            Product product27 = new Product("연세우유솔티캬라멜생크림빵", new DateTime(2023, 4, 25));
            mProducts.Enqueue(product27, product27.Date);

            Product product28 = new Product("루피의콘스위트닭다리", new DateTime(2023, 4, 26));
            mProducts.Enqueue(product28, product28.Date);

            Product product29 = new Product("마이멜로디딸기요거샌드", new DateTime(2023, 4, 27));
            mProducts.Enqueue(product29, product29.Date);

            Product product30 = new Product("풀무원생소면", new DateTime(2023, 4, 27));
            mProducts.Enqueue(product30, product30.Date);

            Product product31 = new Product("비비고썰은배추김치", new DateTime(2023, 4, 27));
            mProducts.Enqueue(product31, product31.Date);

            Product product32 = new Product("풀무원밀떡볶이떡", new DateTime(2023, 4, 28));
            mProducts.Enqueue(product32, product32.Date);

            Product product33 = new Product("연세생크림우유롤케익", new DateTime(2023, 4, 28));
            mProducts.Enqueue(product33, product33.Date);

            Product product34 = new Product("존쿡킬바사270g", new DateTime(2023, 4, 29));
            mProducts.Enqueue(product34, product34.Date);

            Product product35 = new Product("상디의통구이삼겹살", new DateTime(2023, 4, 29));
            mProducts.Enqueue(product35, product35.Date);

            Product product36 = new Product("촉촉야들훈제막창", new DateTime(2023, 4, 30));
            mProducts.Enqueue(product36, product36.Date);

            Product product37 = new Product("불고기왕꼬치", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product37, product37.Date);

            Product product38 = new Product("의성마늘후랑크70g", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product38, product38.Date);

            Product product39 = new Product("천하장사대파후랑크", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product39, product39.Date);

            Product product40 = new Product("주종발효밤맛만쥬", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product40, product40.Date);

            Product product41 = new Product("쿠키크림케익", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product41, product41.Date);

            Product product42 = new Product("동의오리지널반숙란", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product42, product42.Date);

            Product product43 = new Product("행복2란?훈제란", new DateTime(2023, 5, 1));
            mProducts.Enqueue(product43, product43.Date);

            Product product44 = new Product("사조안심오븐구이치킨윙", new DateTime(2023, 5, 2));
            mProducts.Enqueue(product44, product44.Date);

            Product product45 = new Product("쉐프엠투움바파스타", new DateTime(2023, 5, 2));
            mProducts.Enqueue(product45, product45.Date);

            Product product46 = new Product("동의오리지널반숙란", new DateTime(2023, 5, 2));
            mProducts.Enqueue(product46, product46.Date);

            Product product47 = new Product("짱구는치즈를좋아해", new DateTime(2023, 5, 3));
            mProducts.Enqueue(product47, product47.Date);

            Product product48 = new Product("스트링치즈", new DateTime(2023, 5, 3));
            mProducts.Enqueue(product48, product48.Date);

            Product product49 = new Product("자이언트닭가슴살오리지널", new DateTime(2023, 5, 3));
            mProducts.Enqueue(product49, product49.Date);

            Product product50 = new Product("주종발효밤맛만쥬", new DateTime(2023, 5, 4));
            mProducts.Enqueue(product50, product50.Date);

            Product product51 = new Product("비비고썰은배추김치", new DateTime(2023, 5, 5));
            mProducts.Enqueue(product51, product51.Date);

            Product product52 = new Product("자이언트떡볶이", new DateTime(2023, 5, 5));
            mProducts.Enqueue(product52, product52.Date);

            Product product53 = new Product("풀무원순쌀가래떡", new DateTime(2023, 5, 5));
            mProducts.Enqueue(product53, product53.Date);

            Product product54 = new Product("로스트치킨하바네로직화구이", new DateTime(2023, 5, 6));
            mProducts.Enqueue(product54, product54.Date);

            Product product55 = new Product("국민안주푸짐한한판모둠순대", new DateTime(2023, 5, 6));
            mProducts.Enqueue(product55, product55.Date);

            Product product56 = new Product("맥스봉직화구이꼬치바청양고추", new DateTime(2023, 5, 7));
            mProducts.Enqueue(product56, product56.Date);

            Product product57 = new Product("매운돼지갈비찜", new DateTime(2023, 5, 7));
            mProducts.Enqueue(product57, product57.Date);

            Product product58 = new Product("맥스봉구운마늘후랑크", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product58, product58.Date);

            Product product59 = new Product("쿠키앤크림찰떡", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product59, product59.Date);

            Product product60 = new Product("딸기우유찰떡", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product60, product60.Date);

            Product product61 = new Product("자이언트라볶이", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product61, product61.Date);

            Product product62 = new Product("달콤달콤허니볼", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product62, product62.Date);

            Product product63 = new Product("쥬시쿨자두", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product63, product63.Date);

            Product product64 = new Product("쉐프엠베이컨까르보나라파스타", new DateTime(2023, 5, 8));
            mProducts.Enqueue(product64, product64.Date);

            Product product65 = new Product("사조안심오븐구이치킨봉", new DateTime(2023, 5, 9));
            mProducts.Enqueue(product65, product65.Date);

            Product product66 = new Product("꽃카딸기크림붓세", new DateTime(2023, 5, 9));
            mProducts.Enqueue(product66, product66.Date);

            Product product67 = new Product("도로로의캬라멜스콘", new DateTime(2023, 5, 10));
            mProducts.Enqueue(product67, product67.Date);

            Product product68 = new Product("맥스봉직화구이꼬치바오리지널", new DateTime(2023, 5, 11));
            mProducts.Enqueue(product68, product68.Date);

            Product product69 = new Product("루피의통닭다리꼬꼬밥", new DateTime(2023, 5, 11));
            mProducts.Enqueue(product69, product69.Date);

            Product product70 = new Product("맥스봉팝비엔나", new DateTime(2023, 5, 12));
            mProducts.Enqueue(product70, product70.Date);

            Product product71 = new Product("오븐에구운버터휘낭시에", new DateTime(2023, 5, 12));
            mProducts.Enqueue(product71, product71.Date);

            Product product72 = new Product("맥스봉숯불구이맛핫바", new DateTime(2023, 5, 13));
            mProducts.Enqueue(product72, product72.Date);

            Product product73 = new Product("HEYROO핫바득템오리지널", new DateTime(2023, 5, 13));
            mProducts.Enqueue(product73, product73.Date);

            Product product74 = new Product("행복2란?구운란", new DateTime(2023, 5, 13));
            mProducts.Enqueue(product74, product74.Date);

            Product product75 = new Product("행복2란?훈제란", new DateTime(2023, 5, 13));
            mProducts.Enqueue(product75, product75.Date);

            Product product76 = new Product("천하장사대파후랑크", new DateTime(2023, 5, 15));
            mProducts.Enqueue(product76, product76.Date);

            Product product77 = new Product("행복2란?훈제란", new DateTime(2023, 5, 15));
            mProducts.Enqueue(product77, product77.Date);

            Product product78 = new Product("맥스봉청양고추후랑크", new DateTime(2023, 5, 16));
            mProducts.Enqueue(product78, product78.Date);

            Product product79 = new Product("맥스봉숯불구이맛핫바", new DateTime(2023, 5, 17));
            mProducts.Enqueue(product79, product79.Date);

            Product product80 = new Product("풀무원새콤달콤유부초밥", new DateTime(2023, 5, 18));
            mProducts.Enqueue(product80, product80.Date);

            Product product81 = new Product("의성마늘후랑크70g", new DateTime(2023, 5, 19));
            mProducts.Enqueue(product81, product81.Date);

            Product product82 = new Product("쉐프엠베이컨까르보나라파스타", new DateTime(2023, 5, 19));
            mProducts.Enqueue(product82, product82.Date);

            Product product83 = new Product("윤기좔좔한돈순살족발", new DateTime(2023, 5, 19));
            mProducts.Enqueue(product83, product83.Date);

            Product product84 = new Product("하림닭가슴살블랙페퍼", new DateTime(2023, 5, 19));
            mProducts.Enqueue(product84, product84.Date);

            Product product85 = new Product("닭가슴살소시지", new DateTime(2023, 5, 19));
            mProducts.Enqueue(product85, product85.Date);

            Product product86 = new Product("시원한오뎅한그릇", new DateTime(2023, 5, 19));
            mProducts.Enqueue(product86, product86.Date);

            Product product87 = new Product("의성마늘핫바빅90g", new DateTime(2023, 5, 20));
            mProducts.Enqueue(product87, product87.Date);

            Product product88 = new Product("자이언트라볶이", new DateTime(2023, 5, 20));
            mProducts.Enqueue(product88, product88.Date);

            Product product89 = new Product("훈제닭다리180g", new DateTime(2023, 5, 20));
            mProducts.Enqueue(product89, product89.Date);

            Product product90 = new Product("자이언트떡볶이", new DateTime(2023, 5, 20));
            mProducts.Enqueue(product90, product90.Date);

            Product product91 = new Product("로스트치킨하바네로직화구이", new DateTime(2023, 5, 20));
            mProducts.Enqueue(product91, product91.Date);

            Product product92 = new Product("맥스봉구운마늘후랑크", new DateTime(2023, 5, 21));
            mProducts.Enqueue(product92, product92.Date);

            Product product93 = new Product("맥스봉청양고추후랑크", new DateTime(2023, 5, 22));
            mProducts.Enqueue(product93, product93.Date);

            Product product94 = new Product("국민안주푸짐한한판모둠순대", new DateTime(2023, 5, 22));
            mProducts.Enqueue(product94, product94.Date);

            Product product95 = new Product("HEYROO핫바득템매콤", new DateTime(2023, 5, 22));
            mProducts.Enqueue(product95, product95.Date);

            Product product96 = new Product("닭가슴살소시지청양고추", new DateTime(2023, 5, 22));
            mProducts.Enqueue(product96, product96.Date);

            Product product97 = new Product("더건강한부드러운닭가슴살통살훈제", new DateTime(2023, 5, 23));
            mProducts.Enqueue(product97, product97.Date);

            Product product98 = new Product("하림닭가슴살블랙페퍼", new DateTime(2023, 5, 23));
            mProducts.Enqueue(product98, product98.Date);

            Product product99 = new Product("HEYROO핫바득템오리지널", new DateTime(2023, 5, 23));
            mProducts.Enqueue(product99, product99.Date);

            Product product100 = new Product("깨끗한계란", new DateTime(2023, 5, 25));
            mProducts.Enqueue(product100, product100.Date);

            Product product101 = new Product("시원한오뎅한그릇", new DateTime(2023, 5, 25));
            mProducts.Enqueue(product101, product101.Date);

            Product product102 = new Product("대림선숯불구이맛후랑크2", new DateTime(2023, 5, 27));
            mProducts.Enqueue(product102, product102.Date);

            Product product103 = new Product("자이언트떡볶이순한맛", new DateTime(2023, 5, 27));
            mProducts.Enqueue(product103, product103.Date);

            Product product104 = new Product("HEYROO핫바득템오리지널", new DateTime(2023, 5, 27));
            mProducts.Enqueue(product104, product104.Date);

            Product product105 = new Product("친친오리지널소시지", new DateTime(2023, 5, 28));
            mProducts.Enqueue(product105, product105.Date);

            Product product106 = new Product("천하장사오리지날빅70g", new DateTime(2023, 5, 29));
            mProducts.Enqueue(product106, product106.Date);

            Product product107 = new Product("더건강한부드러운닭가슴살통살훈제", new DateTime(2023, 5, 30));
            mProducts.Enqueue(product107, product107.Date);

            Product product108 = new Product("자이언트떡볶이순한맛", new DateTime(2023, 5, 31));
            mProducts.Enqueue(product108, product108.Date);

            Product product109 = new Product("상디의비법돈코츠라멘", new DateTime(2023, 6, 6));
            mProducts.Enqueue(product109, product109.Date);

            Product product110 = new Product("천하장사짱구", new DateTime(2023, 6, 7));
            mProducts.Enqueue(product110, product110.Date);

            Product product111 = new Product("자이언트청양베이컨크림떡볶이", new DateTime(2023, 6, 8));
            mProducts.Enqueue(product111, product111.Date);

            Product product112 = new Product("부드러운닭가슴살통살구이페퍼", new DateTime(2023, 6, 12));
            mProducts.Enqueue(product112, product112.Date);

            Product product113 = new Product("천하장사건강닭", new DateTime(2023, 6, 13));
            mProducts.Enqueue(product113, product113.Date);

            Product product114 = new Product("자연면투움바파스타", new DateTime(2023, 6, 14));
            mProducts.Enqueue(product114, product114.Date);

            Product product115 = new Product("이웃집통통이약과쿠키", new DateTime(2023, 6, 17));
            mProducts.Enqueue(product115, product115.Date);

            Product product116 = new Product("맥스봉오리지널", new DateTime(2023, 6, 19));
            mProducts.Enqueue(product116, product116.Date);

            Product product117 = new Product("친친오리지널소시지", new DateTime(2023, 6, 22));
            mProducts.Enqueue(product117, product117.Date);

            Product product118 = new Product("종가집볶음김치", new DateTime(2023, 6, 24));
            mProducts.Enqueue(product118, product118.Date);

            Product product119 = new Product("뿌려뿌려치즈파티", new DateTime(2023, 6, 28));
            mProducts.Enqueue(product119, product119.Date);

            Product product120 = new Product("종가집볶음김치", new DateTime(2023, 6, 28));
            mProducts.Enqueue(product120, product120.Date);

            Product product121 = new Product("호로록수제비", new DateTime(2023, 6, 29));
            mProducts.Enqueue(product121, product121.Date);

            Product product122 = new Product("천하장사50g", new DateTime(2023, 6, 29));
            mProducts.Enqueue(product122, product122.Date);

            Product product123 = new Product("천하장사오리지날빅70g", new DateTime(2023, 6, 29));
            mProducts.Enqueue(product123, product123.Date);

            Product product124 = new Product("천하장사28g", new DateTime(2023, 6, 29));
            mProducts.Enqueue(product124, product124.Date);

            Product product125 = new Product("뿌려뿌려치즈파티", new DateTime(2023, 6, 30));
            mProducts.Enqueue(product125, product125.Date);

            Product product126 = new Product("칠갑농산짬뽕수제비", new DateTime(2023, 7, 1));
            mProducts.Enqueue(product126, product126.Date);

            Product product127 = new Product("맥스봉프로틴", new DateTime(2023, 7, 2));
            mProducts.Enqueue(product127, product127.Date);

            Product product128 = new Product("꼬마단무지", new DateTime(2023, 7, 5));
            mProducts.Enqueue(product128, product128.Date);

            Product product129 = new Product("맥스봉치즈70g", new DateTime(2023, 7, 8));
            mProducts.Enqueue(product129, product129.Date);

            Product product130 = new Product("뿌려뿌려치즈파티", new DateTime(2023, 7, 9));
            mProducts.Enqueue(product130, product130.Date);

            Product product131 = new Product("메밀소바", new DateTime(2023, 7, 12));
            mProducts.Enqueue(product131, product131.Date);

            Product product132 = new Product("냉우동", new DateTime(2023, 7, 13));
            mProducts.Enqueue(product132, product132.Date);

            Product product133 = new Product("풀무원생냉면", new DateTime(2023, 7, 16));
            mProducts.Enqueue(product133, product133.Date);

            Product product134 = new Product("고구마모니카", new DateTime(2023, 7, 16));
            mProducts.Enqueue(product134, product134.Date);

            Product product135 = new Product("의정부식부대짜글이", new DateTime(2023, 7, 19));
            mProducts.Enqueue(product135, product135.Date);

            Product product136 = new Product("천하장사28g", new DateTime(2023, 7, 19));
            mProducts.Enqueue(product136, product136.Date);

            Product product137 = new Product("맥스봉오리지널", new DateTime(2023, 7, 19));
            mProducts.Enqueue(product137, product137.Date);

            Product product138 = new Product("천하장사50g", new DateTime(2023, 7, 20));
            mProducts.Enqueue(product138, product138.Date);

            Product product139 = new Product("자연면투움바파스타", new DateTime(2023, 7, 22));
            mProducts.Enqueue(product139, product139.Date);

            Product product140 = new Product("조미찢은오징어채", new DateTime(2023, 8, 5));
            mProducts.Enqueue(product140, product140.Date);

            Product product141 = new Product("CJ얼큰우동", new DateTime(2023, 8, 14));
            mProducts.Enqueue(product141, product141.Date);

            Product product142 = new Product("쉐푸드까르보나라", new DateTime(2023, 8, 20));
            mProducts.Enqueue(product142, product142.Date);

            Product product143 = new Product("훈제메추리알3입", new DateTime(2023, 8, 20));
            mProducts.Enqueue(product143, product143.Date);

            Product product144 = new Product("햇반솥반꿀약밥", new DateTime(2023, 8, 24));
            mProducts.Enqueue(product144, product144.Date);

            Product product145 = new Product("오뚜기양평식선지해장국", new DateTime(2023, 8, 30));
            mProducts.Enqueue(product145, product145.Date);

            Product product146 = new Product("파스타랑볼로네제", new DateTime(2023, 9, 2));
            mProducts.Enqueue(product146, product146.Date);

            Product product147 = new Product("풀무원평양물냉면육수", new DateTime(2023, 9, 22));
            mProducts.Enqueue(product147, product147.Date);

            Product product148 = new Product("체다치즈5매입", new DateTime(2023, 9, 22));
            mProducts.Enqueue(product148, product148.Date);

            Product product149 = new Product("황태채", new DateTime(2023, 10, 1));
            mProducts.Enqueue(product149, product149.Date);

            Product product150 = new Product("다담순두부찌개양념", new DateTime(2023, 10, 16));
            mProducts.Enqueue(product150, product150.Date);

            Product product151 = new Product("동원진한사골쌀떡국", new DateTime(2023, 11, 1));
            mProducts.Enqueue(product151, product151.Date);

            Product product152 = new Product("파스타랑볼로네제", new DateTime(2023, 11, 2));
            mProducts.Enqueue(product152, product152.Date);

            Product product153 = new Product("파스타랑알리오올리오", new DateTime(2023, 11, 8));
            mProducts.Enqueue(product153, product153.Date);

            Product product154 = new Product("다담고깃집된장찌개양념", new DateTime(2023, 11, 12));
            mProducts.Enqueue(product154, product154.Date);

            Product product155 = new Product("젤리블리한라봉", new DateTime(2024, 2, 8));
            mProducts.Enqueue(product155, product155.Date);

            Product product156 = new Product("HEYROO미소된장국", new DateTime(2024, 2, 29));
            mProducts.Enqueue(product156, product156.Date);

            Product product157 = new Product("젤리블리샤인머스켓", new DateTime(2024, 3, 6));
            mProducts.Enqueue(product157, product157.Date);

            Product product158 = new Product("HEYROO미역국", new DateTime(2024, 3, 19));
            mProducts.Enqueue(product158, product158.Date);

            Product product159 = new Product("The미식닭개장", new DateTime(2024, 3, 22));
            mProducts.Enqueue(product159, product159.Date);

            Product product160 = new Product("HEYROO미소된장국", new DateTime(2024, 4, 5));
            mProducts.Enqueue(product160, product160.Date);
        }

        public void AddProduct(Product product)
        {
            Debug.Assert(product != null);

            mProducts.Enqueue(product, product.Date);
        }

        public void RemoveProduct()
        {
            while (mProducts.Count != 0
                && (GetKST() - mProducts.Peek().Date).TotalDays > 2)
            {
                mProducts.Dequeue();
            }
        }

        public void RemoveProduct(string name, string year, string month, string day)
        {
            PriorityQueue<Product, DateTime> copiedProducts = new PriorityQueue<Product, DateTime>(CAPACITY);

            int yearInt = int.Parse(year);
            int monthInt = int.Parse(month);
            int dayInt = int.Parse(day);

            DateTime date = new DateTime(yearInt, monthInt, dayInt);

            while (mProducts.Count != 0)
            {
                Product product = mProducts.Dequeue();

                if (product.Name != name || product.Date != date)
                {
                    copiedProducts.Enqueue(product, product.Date);
                }
            }

            mProducts = copiedProducts;
        }

        public List<Product> GetProducts()
        {
            List<Product> retProducts = new List<Product>(CAPACITY);
            PriorityQueue<Product, DateTime> copiedProducts = new PriorityQueue<Product, DateTime>(CAPACITY);

            while (mProducts.Count != 0)
            {
                Product product = mProducts.Dequeue();

                retProducts.Add(product);
                copiedProducts.Enqueue(product, product.Date);
            }

            mProducts = copiedProducts;

            return retProducts;
        }

        public static DateTime GetKST()
        {
            return DateTime.UtcNow.AddHours(9);
        }
    }
}
